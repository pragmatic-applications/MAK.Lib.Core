﻿namespace Domain;

public class FileMain
{
    public static string GetContentType(string path)
    {
        var types = GetMimeTypes();
        var ext = Path.GetExtension(path).ToLowerInvariant();

        return types[ext];
    }

    private static Dictionary<string, string> GetMimeTypes() => new Dictionary<string, string>
        {
              {".txt", "text/plain"},
              {".pdf", "application/pdf"},
              {".doc", "application/vnd.ms-word"},
              {".docx", "application/vnd.ms-word"},
              {".xls", "application/vnd.ms-excel"},
              {".xlsx", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"},
              {".png", "image/png"},
              {".jpg", "image/jpeg"},
              {".jpeg", "image/jpeg"},
              {".gif", "image/gif"},
              {".csv", "text/csv"}
        };
}
