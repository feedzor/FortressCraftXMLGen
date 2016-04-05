using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GACXmlGenerator
{
    public class ValidationInfo
    {
        public enum StatusEnum { OK, Error, Warning }
        public StatusEnum Status;
        public String Message { get; set; }

        /// <summary>
        /// Put default error Message: OK, ERROR, WARNING
        /// </summary>
        /// <param name="status"></param>
        public ValidationInfo(StatusEnum status)
        {
            switch (status)
            {
                case StatusEnum.OK: Message = "OK"; break;
                case StatusEnum.Error: Message = "Error"; break;
                case StatusEnum.Warning: Message = "Warning"; break;
            }
        }

        public ValidationInfo(StatusEnum status, String message)
        {
            this.Status = status;
            this.Message = message;
        }
    }
}
