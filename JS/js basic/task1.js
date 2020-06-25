const string = "Привет! Как дела?";

function getVowels(str){
    str = str.replace(/[^аеёиоуыэюя]/ig, '');
    return str;
}


console.log(getVowels(string));


