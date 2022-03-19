﻿namespace Extensions;

public static class FormFileExtensions
{
    public static string GetFilename(this IFormFile file) =>
    ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.ToString().Trim('"');

    public static async Task<MemoryStream> GetFileStream(this IFormFile file)
    {
        var filestream = new MemoryStream();
        await file.CopyToAsync(filestream);
        return filestream;
    }

    public static async Task<byte[]> GetFileArray(this IFormFile file)
    {
        var filestream = new MemoryStream();
        await file.CopyToAsync(filestream);
        return filestream.ToArray();
    }
}
