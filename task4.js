let names = [];
names[0]="Irada";
names[1]="Akif";
names[2]="Fidan";
names[3]="Amalia";
names[4]="Anar";
let counter = 0;
for(let i=0; i < names.length; i++){
    if(names[i].startsWith("A")){
        counter++;
    }
    
}
console.log(counter);
