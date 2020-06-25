      
      const mixedArray = [3,13,74,14,66,15,22,4];
      const isEven = num =>   num % 2 === 0 ;

      console.log(filterArray(mixedArray, isEven));
     
      function filterArray(mixedArray, isEven){
          for(var i = 0; i < mixedArray.length; i++)
          {
              console.log(mixedArray[i]);
            if(!isEven(mixedArray[i]))
            {
               mixedArray.splice(i, 1);
               i--;
            }
          }
          return mixedArray;
      }
