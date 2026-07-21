using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageViewer
{
    public class ImageService
    {
        public List<ImageRecord> LoadImages(string folder)
        {
            List<ImageRecord> images = new();

            string[] files = Directory.GetFiles(folder);

            int id = 1;

            foreach (string file in files)
            {
                images.Add(new ImageRecord
                {
                    Id = id++,
                    Name = Path.GetFileName(file),
                    Location = folder,
                    ImagePath = file
                });
            }

            return images;
        }

        }
}
