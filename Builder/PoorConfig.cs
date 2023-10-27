using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Builder
{
    public class PoorConfig : Builder
    {
        private CS config = new CS();
        private Logger.Logger logger = Logger.Logger.GetInstance();

            
        public override void reset()
        {
            config.GPU = "";
            config.CPU = "";
            config.RAM = "";
            config.Memory = "";
            config.Case = "";
            config.Cooling = "";
            config.MB = "";
            config.PowerSupply = "";
            config.picture = null;
            logger.Log("Config reseted");
        }

        public override void setGPU()
        {
            config.GPU = "ATI 100-505144 FireGL V7300 512 MB Video Card";
            logger.Log($"GPU set to {config.GPU}");
        }
        public override void setCPU()
        {
            config.CPU = "Intel Xeon E5-2650L V2 1.7 GHz 10-Core OEM/Tray Processor";
            logger.Log($"CPU set to {config.CPU}");
        }
        public override void setRam()
        {
            config.RAM = "Kingston ValueRAM 4 GB (1 x 4 GB) DDR4-3200 CL22 Memory";
            logger.Log($"RAM set to {config.RAM}");
        }
        public override void setMemory()
        {
            config.Memory = "Crucial MX300 1.05 TB 2.5'' Solid State Drive";
            logger.Log($"Memory set to {config.Memory}");
        }
        public override void setCase()
        {
            config.Case = "Aerocool CS-101 MicroATX Slim Case";
            logger.Log($"Case set to {config.Case}");
        }
        public override void setCooling()
        {
            config.Cooling = "ARCTIC Alpine 23 CPU Cooler";
            logger.Log($"Cooling set to {config.Cooling}");
        }
        public override void setMB()
        {
            config.MB = "MSI B450M-A PRO MAX Micro ATX AM4 Motherboard";
            logger.Log($"MB set to {config.MB}");
        }
        public override void setPW()
        {
            config.PowerSupply = "EVGA SuperNOVA 750 GT 750 W 80+ Gold Certified Fully Modular ATX Power Supply";
            logger.Log($"PowerSupply set to {config.PowerSupply}");
        }

        public override void setPicture()
        {
            config.picture = Image.FromFile(@"E:\!College\KPZ\BuilderDesignPattern\BuilderDesignPattern\images\poor.jpg");
            logger.Log($@"picture set to E:\!College\KPZ\BuilderDesignPattern\BuilderDesignPattern\images\poor.jpg");
        }

        public override CS Build()
        {
            setGPU();
            setCPU();
            setRam();
            setMemory();
            setCase();
            setCooling();
            setMB();
            setPW();
            setPicture();
            logger.Log("Poor config was built successfully");
            logger.ShowLogs();
            return config;
        }
    }
}
