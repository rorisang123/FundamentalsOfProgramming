using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Interfaces;

namespace Adapters
{
    public class ImageAdapter : IImageAdapter
    {
        public string GenerateDog()
        {
            return "https://images.dog.ceo/breeds/hound-blood/n02088466_9360.jpg";

        }
    }
}
