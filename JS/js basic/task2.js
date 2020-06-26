    const workers = [
    {"name":"John","salary":500},
    {"name":"Mike","salary":1300},
    {"name":"Linda","salary":1500}];

  console.log(getWorthyWorkers(workers))

  function getWorthyWorkers( workrs){
      console.log(workrs.length);
      for(var i = 0; i < workrs.length; i++)
      {
          if(workrs[i].salary < 1000)
          {
             workrs.splice(i, 1);
             i--;
          }
 
      }
      return workrs;
  }