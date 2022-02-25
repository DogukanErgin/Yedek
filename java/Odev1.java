
public class Odev1 {
    public static String encrypt(String originalText,  String key)
    {
        String text = "";//metin burada oluşacak
        originalText = originalText.toUpperCase();
        for (int i = 0, j = 0; i < originalText.length(); i++)
        {
            char encryptText = originalText.charAt(i);
            if (encryptText < 'A' || encryptText > 'Z')
                continue;
            text = text + (char) ((encryptText + key.charAt(j)- (2 * 'A')+1) %26 + 'A');
            j = ++j % key.length();//şifre orjinal metinden daha kısa olduğu için kendini tekrar etmesini burada sağladık
        }
        return text;
    }

    public static String decrypt(String encryptedText,  String key)
    {
        String text = "";
        encryptedText = encryptedText.toUpperCase();
        for (int i = 0, j = 0; i < encryptedText.length(); i++)
        {
            char decryptText = encryptedText.charAt(i);
            if (decryptText < 'A' || decryptText > 'Z')
                continue;
            text = text+ (char) ((decryptText - key.charAt(j) + 25) % 26 + 'A');
            j = ++j % key.length();
        }
        return text;
    }

    public static void main(String[] args)
    {
        String key = "CLASS";
        String message = "OBJECTORIANTEDPROGRAMMING";
        String encryptedMsg = encrypt(message, key);
        System.out.println("String: " + message);
        System.out.println("Encrypted message: " + encryptedMsg);
        System.out.println("Decrypted message: " + decrypt(encryptedMsg, key));
    }
}


