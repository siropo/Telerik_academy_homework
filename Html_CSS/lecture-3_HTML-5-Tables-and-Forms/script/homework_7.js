function Check(chk)
{
	if (document.myform.check_ctr.checked==true) {
		for (i = 0; i < chk.length; i++)
		chk[i].checked = true ;
	} else {
		for (i = 0; i < chk.length; i++)
		chk[i].checked = false ;
	}
}