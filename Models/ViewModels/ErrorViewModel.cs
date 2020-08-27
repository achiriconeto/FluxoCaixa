using System;

namespace FluxoCaixa03.Models.ViewModels
{
    public class ErrorViewModel 
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}