#include <iostream>
#include <string>

class Singleton {
    private: 
        static int counter;
        std::string val;
        static Singleton* instance;
    protected:
        Singleton(const std::string& val): val(val) {
            Singleton::counter++;
            std::cout << counter << std::endl;
        }
    public:

        static Singleton* GetInstance(const std::string& val);
};

int Singleton::counter = 0;
Singleton* Singleton::instance = nullptr;

Singleton* Singleton::GetInstance(const std::string& val) {
    if (Singleton::instance == nullptr)
        Singleton::instance = new Singleton(val);

}

class Derived: public Singleton {
    public:
        // No default constructor for Singleton
        // Derived() {

        // }
};

/* In C# we generally use `sealed` keyword with the singleton class to avoid other classes to extend the singleton class as well as chaining. 

But this problem can be solved by putting the other class inside the singleton class and this to be done with Singleton class declared with the sealed keyword to avoid inheritance instead use chaining which created the new instance of the singleton when the chaining is happening*/

int main() {
    // Since we have two s and s1 trying to call GetInstance this could get an error. So we need to make sure once the call of s is completed then only the call of s1 should be entertained otherwise the if there multiple instances trying to call Singleton::GetInstance could return creating multiple instance of Singleton class. Refer to [Thread Safety in Singleton]
    Singleton* s = Singleton::GetInstance("bar");
    Singleton* s1 = Singleton::GetInstance("foo");
    // Derived* d = new Derived(); // the default constructor of "Derived" cannot be referenced -- it is a deleted functionC/C++(1790)
}