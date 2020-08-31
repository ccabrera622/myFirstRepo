function reverseNum(num)
{
	var str = String(num);
	var result = "";
	for(let i = str.length-1; i>=0;i--)
	{
		result += str[i];
	}

	return Number(result);
}