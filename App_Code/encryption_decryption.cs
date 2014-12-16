using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Security.Cryptography;
using System.Text;

/// <summary>
/// Summary description for encryption_decryption
/// </summary>
public class encryption_decryption
{
	public encryption_decryption()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public static string EncodePassword(string originalPassword)
    {
        Byte[] originalBytes;
        Byte[] encodedBytes;
        MD5 md5;
     
        // Conver the original password to bytes; then create the hash
        md5 = new MD5CryptoServiceProvider();
        originalBytes = ASCIIEncoding.Default.GetBytes(originalPassword);
        encodedBytes = md5.ComputeHash(originalBytes);
     
        // Bytes to string
        return
    
        System.Text.RegularExpressions.Regex.Replace(BitConverter.ToString(encodedBytes), "-", "").ToLower();
    }
}
