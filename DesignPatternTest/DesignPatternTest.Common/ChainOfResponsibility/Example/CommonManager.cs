﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest
{
    public class CommonManager : CORManager
    {
        public CommonManager(string name)
            : base(name)
        {

        }
        public override void RequestApplications(CORRequest request)
        {
            if (request.RequestType == "請假" && request.Number <= 2)
            {
                Console.WriteLine("{0}：{1} 數量{2} 被批準", name, request.RequestContent, request.Number);
            }
            else
            {
                if (manager != null)
                {
                    manager.RequestApplications(request);
                }
            }
        }
    }
}
