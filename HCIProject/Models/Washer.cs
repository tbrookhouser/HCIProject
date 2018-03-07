using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HCIProject.Models
{
    public class Washer : LaundryMachine
    {
        public int id;

        public Washer(int id, String name, String status)
        {
            this.id = id;
            this.machineName = name;
            this.status = status;
        }
    }
}