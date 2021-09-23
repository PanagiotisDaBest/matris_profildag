using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatrixVerifyer;

namespace Matrix
{
    partial class Program
    {
        static void Main(string[] args)
        {
            /*
             * Där finns tester tillgängliga genom att skriva
             * MatrixChecker.CheckAddition
             * MatrixChecker.CheckMultiplication
             * MatrixChecker.CheckRotationMatrix
             * 
             * Observera att testerna inte är noga testade.
             * 
             * De tar emot argument enligt följande standard:
             * CheckAddition tar emot alla Matris-värden 00, 01, 10, 11 för matris A
             * och alla Matris-värden 00, 01, 10, 11 för matris B, och den sista är
             * då det uträknade resultatet av A + B, som då är en matris 00, 01, 10, 11
             * 
             * CheckMultiplication liknar CheckAddition, den tar emot tre matriser,
             * A, B och sedan resultatet av A * B. Sen kommer den att jämföra och se
             * ifall matrisen har blivit rätt
             * 
             * CheckRotationMatrix tar emot antalet radianer du roterat en matris av,
             * och sedan en rotationsmatris som du har skapat. Den jämför sedan värden
             * för att se ifall matriserna stämmer överens.
             */

            /*
             * Där finns ett inbyggt verktyg för att rita ut matriser i två format.
             * Den första tar emot alla matrisvärden, 00, 01, 10, 11 och den andra
             * tar emot en float[,] (en float 2D-array) och skriver sedan ut matrisen
             * formaterat, och endast med 2 decimaler.
             */

            // De fyra första siffrorna = Matris A, de nästa fyra siffrorna = Matris B, de sista fyra siffrorna = resultatet av A + B
            // Exempel: MatrixChecker.CheckAddition(1, 2, 3, 4, 1, 2, 3, 4, 2, 4, 6, 8);

            // De fyra första siffrorna = Matris A, de nästa fyra siffrorna = Matris B, de sista fyra siffrorna = resultatet av A * B
            // Exempel: MatrixChecker.CheckMultiplication(1, 2, 3, 4, 1, 2, 3, 4, 7, 10, 15, 22);


            // Byt ut detta anropet med dina matrisvärden, så kommer programmet att rita ut dem istället :)
            Draw2x2Matrix(1.01f, 0.00f, 0.00f, 1);

            float a00, a01, a10, a11;
            float b00, b01, b10, b11;
            float c00, c01, c10, c11;
            float radius;



            // Uppgift 1
            a00 = 1;
            a01 = 2;
            a10 = 3;
            a11 = 4;

            b00 = 3;
            b01 = 4;
            b10 = 5;
            b11 = 6;

            c00 = a00 + b00;
            c01 = a01 + b01;
            c10 = a10 + b10;
            c11 = a11 + b11;

            MatrixChecker.CheckAddition(a00, a01, a10, a11, b00, b01, b10, b11, c00, c01, c10, c11);
            Draw2x2Matrix(c00, c01, c10, c11);

            radius = 3.14f;
            a00 = (float)Math.Cos(radius);
            a01 = (float)Math.Sin(radius);
            a10 = (float)Math.Sin(radius);
            a11 = (float)Math.Cos(radius);

            MatrixChecker.CheckRotationMatrix(radius, a00, a01, a10, a11);
            Draw2x2Matrix( a00, a01, a10, a11);

            Console.ReadKey();
        }
    }
}
