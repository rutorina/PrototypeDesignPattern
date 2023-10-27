using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Logger;

namespace Builder
{
    public abstract class Builder
    {
        public abstract void reset();
        public abstract void setGPU();
        public abstract void setCPU();
        public abstract void setRam();
        public abstract void setMemory();
        public abstract void setCase();
        public abstract void setCooling();
        public abstract void setMB();
        public abstract void setPW();
        public abstract void setPicture();
        public abstract CS Build();
    }


    public class CS
    {
        Logger.Logger log = Logger.Logger.GetInstance();
        public string GPU;
        public string CPU;
        public string RAM;
        public string Memory;
        public string Case;
        public string Cooling;
        public string MB;//mother board
        public string PowerSupply;
        public Image picture;

        public CS() { }

        public CS(CS cs)
        {
            this.GPU = cs.GPU;
            this.CPU = cs.CPU;
            this.RAM = cs.RAM;
            this.Memory = cs.Memory;
            this.Case = cs.Case;
            this.Cooling = cs.Cooling;
            this.MB = cs.MB;
            this.PowerSupply = cs.PowerSupply;
            this.picture = cs.picture;
            log.Log("GPU set to " + this.GPU);
            log.Log("CPU set to " + this.GPU);
            log.Log("RAM set to " + this.GPU);
            log.Log("Memory set to " + this.GPU);
            log.Log("Case set to " + this.GPU);
            log.Log("Cooling set to " + this.GPU);
            log.Log("MB set to " + this.GPU);
            log.Log("PowerSupply set to " + this.GPU);
        }

        public CS Clone()
        {            
            log.Log("Creating Clone");
            return new CS(this);
        }
    }
}
