
using crypto;
namespace BlowfishCSharp.Wrapper
{
    public static class BlowFishWrapper
    {
        public static string Encrypt(string value)
        {
            var result = GenerateKeyIV();
            return Security.Encrypt(value, result[0], result[1]);
        }
        public static string Decrypt(string value)
        {
            var result = GenerateKeyIV();
            return Security.Decrypt(value, result[0], result[1]);
        }
        /// <summary>
        /// Retorna array com dois valores Key e IV
        /// </summary>
        /// <returns></returns>
        private static string[] GenerateKeyIV()
        {
            var array = new string[2];
            array[0] = Security.GenerateText(32);
            array[1] = Security.GenerateText(16);
            return array;
        }
    }
}
