using Minio;
using RestSharp.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace MinioTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var endpoint = "127.0.0.1:9000";
            var accessKey = "minioadmin";
            var secretKey = "minioadmin";
            try
            {
                var minio = new MinioClient(endpoint, accessKey, secretKey);
                 Run(minio).Wait();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }

        // File uploader task.
        private async static Task Run(MinioClient minio)
        {
            var bucketName = "mymusic"; 
            var objectName = "test/条件结构流程图.png";
            var filePath =Path.GetFullPath("条件结构流程图.png")  ; 
            try
            {
                // Make a bucket on the server, if not already present.
                bool found = await minio.BucketExistsAsync(bucketName);
                if (!found)
                {
                    await minio.MakeBucketAsync(bucketName);
                }
                Stream saveStream = new FileStream(filePath,FileMode.Open,FileAccess.Read);
                // Upload a file to bucket.
                await minio.PutObjectAsync(bucketName, objectName, saveStream,saveStream.Length);
                Console.WriteLine("Successfully uploaded " + objectName);
                Stream getSteam=new MemoryStream();

                await minio.StatObjectAsync(bucketName, objectName);
                var bytes = new byte[2048];
                await minio.GetObjectAsync(bucketName, objectName, (stream)=> {
                   stream.CopyTo(getSteam);
                    getSteam.Position = 0;
                    //bytes = stream.ReadAsBytes();
                    //getSteam = stream;
                });
                string savePath = Path.GetFullPath(objectName);
                if (File.Exists(savePath))
                {
                    File.Delete(savePath);
                }
                using (FileStream fileStream = new FileStream(savePath, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    // fileStream.cop(getSteam.);
                    //Stream memory = new MemoryStream();
                    //getSteam.CopyTo(memory);
                    //byte[] buff = new byte[2048];
                    //int len = 0;
                     
                    //    fileStream.Write(bytes, 0,len);
                    getSteam.CopyTo(fileStream);
                    //byte[] bytes = new byte[getSteam.Length];
                    //getSteam?.Read(bytes, 0, bytes.Length);
                    //fileStream.Write(bytes, 0, bytes.Length);
                    fileStream.Flush();
                    fileStream.Close();
                }
              
               
            }
            catch (Exception e)
            {
                Console.WriteLine("File Upload Error: {0}", e.Message);
            }
        }
    }
}
