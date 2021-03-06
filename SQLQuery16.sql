USE [Azhar]
GO
/****** Object:  StoredProcedure [dbo].[char_molafat_select_bycontentid0]    Script Date: 01/14/2013 14:08:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



ALTER PROCEDURE [dbo].[char_molafat_select_bycontentid0]

	
	  @char_id int 
	
AS


IF EXISTS(select char_moalafat.id, [char_moalafat].content_type  from char_moalafat where content_id = 0 and char_moalafat.char_id=@char_id)

BEGIN

SELECT	distinct char_moalafat.title_ar ,char_moalafat.title_en ,char_moalafat.title_fr, char_moalafat.id  as id,char_moalafat.complete,char_moalafat.candidate ,char_moalafat.moalaf_type as moalaf_type,
'element_type' = CASE WHEN [char_moalafat].content_type = 6 THEN 'تسجيل تليفزيونى' 
 WHEN [char_moalafat].content_type = 7 THEN 'تسجيل إذاعى' 
 WHEN [char_moalafat].content_type = 8 THEN 'الوثائق' 
 WHEN [char_moalafat].content_type = 9 THEN 'المقالات' 
 WHEN [char_moalafat].content_type = 10 THEN 'الكتب' 
 
 WHEN [char_moalafat].content_type = 12 THEN 'المخطوطات' 
 WHEN [char_moalafat].content_type = 13 THEN 'أطروحة' 

 WHEN [char_moalafat].content_type = 16 THEN 'بحث فى مؤتمر' END , char_moalafat.title_ar as element_type_name_ar ,char_moalafat.title_en as element_type_name_en , 
char_moalafat.title_fr as element_type_name_fr
	
FROM

	[dbo].[char_moalafat]
	
left outer join [content_types] on [char_moalafat].content_type =content_types.id
 

WHERE

	char_moalafat.char_id = @char_id and char_moalafat.content_id = 0 
	
Order By 'element_type', char_moalafat.moalaf_type DESC

end
else
Begin
SELECT	distinct char_moalafat.title_ar ,char_moalafat.title_en ,char_moalafat.title_fr, char_moalafat.id  as id,char_moalafat.complete,char_moalafat.candidate ,char_moalafat.moalaf_type as moalaf_type 
FROM

	[dbo].[char_moalafat]
	
left outer join [content_types] on [char_moalafat].content_type =content_types.id
  where [char_moalafat].content_type = -1
end



set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON














