using Microsoft.AspNetCore.Components;

namespace HappyBlazing.Pages
{
    
    public  class Converter:ComponentBase
    {
        public double Kmh = 0;
        public double Knot = 0;
        public void Convert()
        {
            Knot = Kmh * 0.539957;
        }
    }
}
