using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }

    public class weekModel
    {
        public IList<int> Weeknumbers { get; set; } = new List<int>()
            {
                1,2,3,4,5
            };
    }

}
