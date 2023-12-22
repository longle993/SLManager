using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.DTO
{
    public class Request
    {
        private bool isSuccess;
        private object data;
        private string message;
        public Request() { }

        public Request(bool isSuccess, object data, string message)
        {
            this.isSuccess = isSuccess;
            this.data = data;
            this.message = message;
        }
        public bool IsSuccess { get => isSuccess; set => isSuccess = value; }
        public object Data { get => data; set => data = value; }
        public string Message { get => message; set => message = value; }
    }
}
