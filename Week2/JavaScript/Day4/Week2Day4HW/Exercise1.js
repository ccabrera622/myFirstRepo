function CloneArr(arr)
{
	let clone = [];
	for(let i = 0; i<arr.length; i++)
	{
		clone.push(arr[i]);
	}

	return clone;
}