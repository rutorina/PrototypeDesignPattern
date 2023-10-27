using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Builder
{
    public class RichConfig : Builder
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
            config.GPU = "Gigabyte AORUS XTREME WATERFORCE GeForce RTX 4090 24 GB Video Card";
            logger.Log($"GPU set to {config.GPU}");
        }
        public override void setCPU()
        {
            config.CPU = "AMD Ryzen 5 7600X 4.7 GHz 6-Core Processor";
            logger.Log($"CPU set to {config.CPU}");
        }
        public override void setRam()
        {
            config.RAM = "G.Skill Trident Z5 RGB 32 GB (2 x 16 GB) DDR5-6000 CL36 Memory";
            logger.Log($"RAM set to {config.RAM}");
        }
        public override void setMemory()
        {
            config.Memory = "Samsung 980 Pro 2 TB M.2-2280 PCIe 4.0 X4 NVME Solid State Drive";
            logger.Log($"Memory set to {config.Memory}");
        }
        public override void setCase() 
        {
            config.Case = "Corsair 4000D Airflow ATX Mid Tower Case";
            logger.Log($"Case set to {config.Case}");
        }
        public override void setCooling() 
        {
            config.Cooling = "Cooler Master Hyper 212 Black Edition 42 CFM CPU Cooler";
            logger.Log($"Cooling set to {config.Cooling}");
        }
        public override void setMB()
        {
            config.MB = "Gigabyte B650 AORUS ELITE AX ATX AM5 Motherboard";
            logger.Log($"MB set to {config.MB}");
        }     
        public override void setPW()
        {
            config.PowerSupply = "Corsair RM750e (2023) 750 W 80+ Gold Certified Fully Modular ATX Power Supply";
            logger.Log($"PowerSupply set to {config.PowerSupply}");
        }

        public override void setPicture()
        {
            config.picture = Image.FromFile(@"E:\!College\KPZ\BuilderDesignPattern\BuilderDesignPattern\images\rich.jpg");
            logger.Log($@"picture set to E:\!College\KPZ\BuilderDesignPattern\BuilderDesignPattern\images\rich.jpg");
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
            logger.Log("Rich config was built successfully");
            logger.ShowLogs();
            return config;
        }
    }
}
