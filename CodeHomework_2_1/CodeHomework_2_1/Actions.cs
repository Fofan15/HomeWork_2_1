using System;
using System.IO;

namespace CodeHomework_2_1
{
    class Actions
    {
        Logger log = new Logger();
        Result result = new Result();
        public bool Start() 
        {
            log.Log("Info", "Start method: Start");
            log.LogInfo("Start method: Start");

            result.Status = true;
            bool status = result.Status;

            return status;
        }

        public bool Skip() 
        {
            log.Log("Warning", "Skipped logic in method: Skip");
            log.LogWarning("Skipped logic in method: Skip");

            result.Status = true;
            bool status = result.Status;

            return status;
        }

        public bool Broke() 
        {
            log.LogError("I broke a logic");

            result.Status = false;
            bool status = result.Status;

            return status;
        }
    }
}
