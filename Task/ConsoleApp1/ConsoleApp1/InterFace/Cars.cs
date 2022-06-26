using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.InterFace
{
    public interface Cars
    {
        Cars[] Carss { get; }   
        int CarLimit { get; set; }
        string No { get; set; } 

        void NewAd(Cars Car);

        void ShowAds(string Car);

        void ShowWipAds(string Car); 
        
    }
}
