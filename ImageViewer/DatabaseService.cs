using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;

namespace ImageViewer
{
    public class DatabaseService
    {
        private readonly string connectionString =
    "Server=DOFSCLUSDB;" +
    "Database=MoonShot2;" +
    "Trusted_Connection=True;" +
    "TrustServerCertificate=True;";
        public List<ImageRecord> GetImages()
        {
            List<ImageRecord> images = new();

            using SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            using SqlCommand command = new SqlCommand("DOFS_Images_GetOnHold", connection);

            command.CommandType = CommandType.StoredProcedure;

            using SqlDataReader reader = command.ExecuteReader();

           

            while (reader.Read())
            {
                ImageRecord image = new ImageRecord
                {
                    ImgId = Convert.ToInt32(reader["imgid"]),
                    ImageId = reader["imageid"]?.ToString() ?? "",
                    ImageName = reader["imagename"]?.ToString() ?? "",
                    ImagePath = reader["imagepath"]?.ToString() ?? "",
                    ImageFile = reader["imagefile"]?.ToString() ?? "",
                    SubFolderPath = reader["SubFolderPath"]?.ToString() ?? ""
                };

                images.Add(image);
            }

 //           MessageBox.Show(
 //    $"Loaded {images.Count} images.\n\n" +
 //    $"First Image:\n\n" +
 //    $"{images[0].ImageName}\n" +
 //    $"{images[0].ImagePath}"
 //);

            return images;
        }
    }

}
