$(document).ready(function(){
$('#button1').click(function(){ 
$( "p" ).after( document.createTextNode("New Item") );
$( "p" ).after( "<br>" );
})
});