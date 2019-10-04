using crypto;

namespace BlowfishCSharp.Wrapper
{
  public static class BlowFishWrapper
  {
    private const string KEY = "v68am2Vb5NQoAI9sNrKtQxpbdYrjX4Qixhg315OJdjo=";
    private const string IV = "tcONmecWWfar1dT1H/1WoA==";

    public static string Encrypt(string value)
    {
      return Security.Encrypt(value, KEY, IV);
    }
    public static string Decrypt(string value)
    {
      return Security.Decrypt(value, KEY, IV);
    }
    /// <summary>
    /// Retorna array com dois valores Key e IV
    /// </summary>
    /// <returns></returns>
    public static string[] GenerateKeyIV()
    {
      var array = new string[2];
      array[0] = Security.GenerateText(32);
      array[1] = Security.GenerateText(16);
      return array;
    }
  }
}
