let teachers = ["Assaf", "Shane"];
teachers.push("Zack");
let str = "";
for(let i = 0; i<teachers.length;i++)
{
	str += teachers[i] + " ";
}
console.log(str);
let teacher1 = teachers.pop();
console.log(teacher1);
console.log(teachers);

