using System;
using System.IO;
using System.Text;
using System.Web.Mvc;
namespace Web.Controllers
{
    public class BaseController : Controller
    {
        private ILog _ILog;
        public BaseController()
        {
            _ILog = Log.GetInstance;
        }
        protected override void OnException(ExceptionContext filterContext)
        {
            _ILog.LogException(filterContext.ToString());
            filterContext.ExceptionHandled = true;
            this.View("Error").ExecuteResult(this.ControllerContext);
        }
    }

    internal interface ILog
    {
        void LogException(string message);

    }

    public sealed class Log : ILog
    {
        private Log()
        {
        }
        private static readonly Lazy<Log> instance = new Lazy<Log>(() => new Log());

        public static Log GetInstance
        {
            get
            {
                return instance.Value;
            }
        }

        public void LogException(string message)
        {
            string fileName = string.Format("{0}_{1}.log", "Exception", DateTime.Now.ToShortDateString().Replace("/", "_"));
            string logFilePath = string.Format(@"{0}_{1}", AppDomain.CurrentDomain.BaseDirectory, fileName);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("----------------------------------------");
            sb.AppendLine(DateTime.Now.ToString());
            sb.AppendLine(message);
            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.Write(sb.ToString());
                writer.Flush();
            }
        }

    }
}