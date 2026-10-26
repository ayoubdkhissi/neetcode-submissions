/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
    public int GuessNumber(int n) {
        
        var l = 0;
        var r = n;
        var mid = (int)(((long)(r+l))/ 2);
        
        var result = guess(mid);
        while(result != 0)
        {
            if(result == -1)
            {
                r = mid - 1;
            }
            else
            {
                l = mid + 1;
            }
            mid = (int)(((long)r + l) / 2);
            result = guess(mid);
        }

        return mid;
        
    }
}