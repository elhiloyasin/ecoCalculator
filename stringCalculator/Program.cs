using NUnit.Framework;


namespace Zen.UnitTests
{
    
    public class StringCalculator
    {
     public int Add(string input)
     {
         if(string.IsNullOrWhiteSpace(input)){
             return 0;
         }
         
        var seperatedString = input.Split(',');
        int total = 0;


        foreach(var x in seperatedString){
            total = int.Parse(x)+ total;
        }
           return total;
        
     } 

    }

    [TestFixture]
    public class StringCalculator_Tests
    {
         private StringCalculator _stringCalculator;
        

    

        [SetUp]
        public void SetUp()
        {
            _stringCalculator = new StringCalculator();
        }

        [Test]
        public void calculate_inputIsEmpty_returnsZero()
         {
             var result = _stringCalculator.Add("");

            Assert.AreEqual(result, 0);
         }
            [Test]
        public void calculate_inputIsOne_returnsOne()
         {
          var result = _stringCalculator.Add("1");

            Assert.AreEqual(result, 1);
         }
            [Test]
          public void calculate_inputIsOneCommaTwo_returnsThree()
         {
          var result = _stringCalculator.Add("1,2");

            Assert.AreEqual(result, 3);
         }

         [Test]
          public void calculate_inputIsOneCommaTwoCommaThree_returnsSix()
         {
          var result = _stringCalculator.Add("2,4,6");

            Assert.AreEqual(result, 12);
         }
           
    }
}


