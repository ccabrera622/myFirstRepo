function outer(){
	var a = "blue";
	var b = [1,2,3];

	console.log(a);
	console.log(b);
  
  function inner(a,b) {
  	a = "red";
  	b.pop();
   	console.log(a);
	console.log(b);	
  }
 
  inner(a,b);
  console.log(a);
  console.log(b);	
}
 
outer();