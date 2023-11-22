public class IntegerToWords
	{
        // Time Complexity : O(1), maximum 12 steps to go over the entire number
        // Space Complexity : O(1)
        // Did this code successfully run on Leetcode : Yes
        // Any problem you faced while coding this : No

        string[] below_20 = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten",
                                    "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        string[] tens = { "", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

        string[] thousands = { "", "Thousand", "Million", "Billion" };
        int i = 0;//thousands array pointer
        public string NumberToWords(int num) // 314123215456
        {

            if (num == 0)
                return "Zero";
            string result = "";
            
            while(num > 0)
            {
                int triplet = num % 1000;

                if (triplet != 0)
                {
                    result = helper(triplet) + " " + thousands[i] + " " + result;
                }
                i++;
                num = num / 1000;
            }
            return result.Trim();
        }

        private string helper(int num)
        {
            if(num < 20)
            {
                return below_20[num];
            }
            else if(num < 100)
            {
                return tens[num / 10] + " " + helper(num % 10);
            }
            else
            {
                return below_20[num / 100] + " Hundred " + helper(num % 100);
            }
        }
    }
