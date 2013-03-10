function print(outputId,text)
{
	var outputElement = document.getElementById(outputId);
	outputElement.innerHTML = text;
}

function read(inputId)
{	
	var inputElement = document.getElementById(inputId);
	return inputElement.value;
}