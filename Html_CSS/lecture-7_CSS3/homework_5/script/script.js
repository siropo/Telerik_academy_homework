function drawShape() {
	var mountains1 = document.getElementById("mountains1");
	var ctx1 = mountains1.getContext("2d");

	ctx1.beginPath();  
	ctx1.moveTo(150,100);  
	ctx1.lineTo(300,270);  
	ctx1.lineTo(370,180);  
	ctx1.lineTo(480,300);   
	ctx1.lineTo(0,300); 	
	ctx1.fillStyle = "rgb(134, 23, 29)";
	ctx1.fill();  

	
	var mountains2 = document.getElementById("mountains2");
	var ctx2 = mountains2.getContext("2d");

	ctx2.beginPath();  
	ctx2.moveTo(100,200);  
	ctx2.lineTo(200,270);  
	ctx2.lineTo(300,120);  
	ctx2.lineTo(440,300);   
	ctx2.lineTo(0,300); 	
	ctx2.fillStyle = "rgb(134, 23, 29)";
	ctx2.fill();  
	
	var ship = document.getElementById("ship");
	var ctx3 = ship.getContext("2d");
	
	ctx3.beginPath();  
	ctx3.moveTo(0,50);
	ctx3.lineTo(50,50);
	ctx3.lineTo(50, 0);
	ctx3.lineTo(65,10);
	ctx3.lineTo(65,50);
	ctx3.lineTo(100,50);
	ctx3.lineTo(80,70);
	ctx3.lineTo(20,70);
	ctx3.fillStyle = "rgb(255, 255, 255)";
	ctx3.fill();  

	ctx3.closePath();    
	ctx3.fill();
}