using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusVenta.Helpers
{
    public class OperationResponse
    {
        public EnumOperationResult IsSuccess { get; set; }
        public string  Message { get; set; }
        public object Data { get; set; }
        public object Detail { get; set; }

        public OperationResponse(Object data)
        {
            IsSuccess = EnumOperationResult.Success;
            Data = data;
        }

        public OperationResponse(EnumOperationResult isSuccess, string message)
        {
            IsSuccess = isSuccess;
            Message = message;
        }

        public OperationResponse(EnumOperationResult isSuccess, string message, Object data)
        {
            IsSuccess = isSuccess;
            Message = message;
            Data = data;
        }

        public OperationResponse(EnumOperationResult isSuccess, string message, Object data, object detail )
        {
            IsSuccess = isSuccess;
            Message = message;
            Data = data;
            Detail = detail;
        }


        #region  SUCCESS

        public static OperationResponse Success()
        {
            return new OperationResponse(EnumOperationResult.Success,"Operación realizada con éxito");
        }

        public static OperationResponse Success(string message)
        {
            return new OperationResponse(EnumOperationResult.Success, message);
        }

        public static OperationResponse Success(string message, object data)
        {
            return new OperationResponse(EnumOperationResult.Success, message, data );
        }

        public static OperationResponse Success( object data)
        {
            return new OperationResponse(EnumOperationResult.Success, "Operación realizada con éxito", data);
        }

        public static OperationResponse Success(string message ,object data, object detail)
        {
            return new OperationResponse(EnumOperationResult.Success, message, data, detail);
        }

        #endregion

        #region WARNING
        public static OperationResponse Warning(string message)
        {
            return new OperationResponse(EnumOperationResult.Warning, message);
        }

        public static OperationResponse Warning(string message, object data)
        {
            return new OperationResponse(EnumOperationResult.Warning, message, data);
        }

        public static OperationResponse Warning(string message, object data, object detail)
        {
            return new OperationResponse(EnumOperationResult.Warning, message, data, detail);
        }

        public static OperationResponse Warning(object data)
        {
            return new OperationResponse(EnumOperationResult.Warning, "Operación realizada con detalle", data);
        }

        #endregion

        #region FAILURE
        public static OperationResponse Failure(string message)
        {
            return new OperationResponse(EnumOperationResult.Failure, message);
        }

        public static OperationResponse Failure(string message, object data)
        {
            return new OperationResponse(EnumOperationResult.Failure, message, message, data);
        }

        #endregion

    }
}
