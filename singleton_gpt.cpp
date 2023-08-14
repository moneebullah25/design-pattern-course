#include <iostream>
#include <string>
#include <mutex>
#include <vector>
#include <thread>

class Singleton {
private:
    static int counter;
    static Singleton* instance;
    static std::mutex mtx;
    std::string val;

protected:
    Singleton(const std::string& val) : val(val) {
        Singleton::counter++;
        std::cout << "Counter: " << counter << std::endl;
    }

public:
    static Singleton* GetInstance(const std::string& val);

    // The "sealed" functionality - Making sure Singleton can't be inherited.
    Singleton(const Singleton&) = delete;
    Singleton& operator=(const Singleton&) = delete;
};

int Singleton::counter = 0;
Singleton* Singleton::instance = nullptr;
std::mutex Singleton::mtx;

Singleton* Singleton::GetInstance(const std::string& val) {
    if (Singleton::instance == nullptr) {
        std::lock_guard<std::mutex> lock(mtx); // Lock for thread safety
        if (Singleton::instance == nullptr)
            Singleton::instance = new Singleton(val);
    }
    return Singleton::instance;
}

class Derived : public Singleton {
protected:
    // Allow only derived classes to construct
    Derived(const std::string& val) : Singleton(val) {}
};

void ThreadFunction(int id) {
    std::string value = "Thread " + std::to_string(id);
    Singleton* instance = Derived::GetInstance(value);
}

int main() {
    const int numThreads = 5;
    std::vector<std::thread> threads;

    for (int i = 0; i < numThreads; ++i) {
        threads.push_back(std::thread(ThreadFunction, i + 1));
    }

    for (auto& thread : threads) {
        thread.join();
    }

    return 0;
}
