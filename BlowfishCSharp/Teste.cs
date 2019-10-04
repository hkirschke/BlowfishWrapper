using System;
using BlowfishCSharp.Wrapper;

namespace BlowfishCSharp
{
  public static class Teste
  {
    public static string RunTest(string texto)
    {
      var textoCript = BlowFishWrapper.Encrypt(texto);
      var textoDescrip = BlowFishWrapper.Decrypt(textoCript);
      return textoDescrip;
    }
  }
}
