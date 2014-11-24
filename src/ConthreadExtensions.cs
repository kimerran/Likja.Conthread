using HashidsNet;
using System.Linq;

namespace Likja.Conthread
{
    public static class ConthreadExtensions
    {
        private const string DEFAULT_SALT = "conthread.likja.com";
        private const int DEFAULT_MIN_LENGTH = 6;
        private const string DEFAULT_ALPHABET = "qwrtypsdfghjkzxcvbnmQWRTYPSDFGHJKZXCVBNM23456789";
        private const string DEFAULT_SEPS = "chfhqstpCHFHQSTP23456789";

        /// <summary>
        /// Converts an ID to hash text
        /// </summary>
        /// <param name="id"></param>
        /// <param name="salt"></param>
        /// <param name="minLength"></param>
        /// <returns></returns>
        public static string ConvertToHash(this int id, string salt = DEFAULT_SALT, int minLength = DEFAULT_MIN_LENGTH)
        {
            var saltString = salt;

            var hashId = new Hashids(saltString, minLength, DEFAULT_ALPHABET, DEFAULT_SEPS);

            return hashId.Encode(id);
        }

        /// <summary>
        /// Converts a string hash to ID
        /// </summary>
        /// <param name="hashid"></param>
        /// <param name="salt"></param>
        /// <param name="minLength"></param>
        /// <returns></returns>
        public static int ConvertToInt(this string hashid, string salt = DEFAULT_SALT, int minLength = DEFAULT_MIN_LENGTH)
        {
            var saltString = salt;

            var hashId = new Hashids(saltString, minLength, DEFAULT_ALPHABET, DEFAULT_SEPS);

            var decoded = hashId.Decode(hashid).ToList();

            if (decoded.Any())
            {
                return decoded.FirstOrDefault();
            }
            return 0;
        }

    }
}
