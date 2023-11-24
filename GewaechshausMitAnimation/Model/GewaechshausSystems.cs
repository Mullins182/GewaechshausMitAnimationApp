using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GewaechshausMitAnimation.Model
{
    internal class GewaechshausSystems
    {
        private bool lueftung = false;
        private bool kuehlung = false;
        private bool heizung  = false;
        private bool verdunkl = false;

        GewaechshausSystems() { }

        public bool getLueftungStatus()
        { 
            return lueftung;        
        }
        public bool getKuehlungStatus() 
        {
            return kuehlung;            
        }
        public bool getHeizungStatus()
        {
            return heizung;        
        }
        public bool getVerdunklStatus()
        {
            return verdunkl;        
        }

        public void setLueftung(bool value)
        {
            lueftung = value;        
        }
        public void setKuehlung(bool value)
        {  
            kuehlung = value;            
        }
        public void setHeizung(bool value)
        {
            heizung = value;
        }
        public void setVerdunkl(bool value)
        {
            verdunkl = value;
        }

        public void setSystems()
        {

        }

    }
}
