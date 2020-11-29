# מטלה שבועית שבוע 6-משחק באולינג
## מגישים: רינת אוזקסן ודניאל גימפלמן
זהו משחק הבנוי מ3 שלבים, המדמה למשחק באולינג מציאותי.
בשלב הראשון- יש להפיל 3 מוטות
בשלב השני- יש להפיל 10 מוטות
בשלב האחרון- יש להפיל 10 מוטות ממרחק גדול יותר.
### המשחק מכיל 2 סקריפטים עיקריים

### ballmovement -
פונקציה שמקצה לכדור 2 פעולות תזוזה
1. ימינה שמאלה
2. באמצעות מקש הרווח שליחת הכדור במהירות קבועה לכיוון המוטות

בסקריפט זה נעשה זיהוי מתי הכדור עוצר, ובמצב זה נעשות הבדיקות הבאות:
1. אם בוצע סטרייק/נעשו 2 ניסיונות פגיעה- עבור לשלב הבא
2. אחרת, תחזור לנקודת ההתחלה ותזרוק את הכדור שנית

כמו כן בכל פגיעה של הכדור במוט, משתנה למוט הספציפי התג, ובסיום כל ניסיון
מבוצעת מחיקה של כל המוטות שהשתנה להן התג.

### ScoreCount
פונקציה בה מבוצעת ספירה של המוטות שנופלים בכל שלב,
הספירה נעשית ברגע אמת ומופיעה על מסך המשחק.

## עזרים נוספים:
1. prefabs -
יצרנו זאת עבור כל תבנית שחוזרת על עצמה משלב לשלב
2. meterials-
מיועד לעיצוב האובייקטים במחשב
3. עיצוב מיוחד למוט, נעזרנו בסרטון הבא
https://www.youtube.com/watch?v=f4sg5VNh_Z4&ab_channel=TIMDesign

[![](https://scontent.fsdv3-1.fna.fbcdn.net/v/t1.0-9/128054146_3566632896737724_4710530173380698110_o.jpg?_nc_cat=104&ccb=2&_nc_sid=0debeb&_nc_ohc=frWU-7NJBzEAX_1O6lB&_nc_ht=scontent.fsdv3-1.fna&oh=7c725fa77e30ee5f7c5864e1c79c95c7&oe=5FE8FDA1)](http://https://scontent.fsdv3-1.fna.fbcdn.net/v/t1.0-9/128054146_3566632896737724_4710530173380698110_o.jpg?_nc_cat=104&ccb=2&_nc_sid=0debeb&_nc_ohc=frWU-7NJBzEAX_1O6lB&_nc_ht=scontent.fsdv3-1.fna&oh=7c725fa77e30ee5f7c5864e1c79c95c7&oe=5FE8FDA1)

[![](https://scontent.fsdv3-1.fna.fbcdn.net/v/t1.0-9/128051215_3566632900071057_973295284218645986_o.jpg?_nc_cat=107&ccb=2&_nc_sid=0debeb&_nc_ohc=XEetpKHWYGMAX8Np80C&_nc_ht=scontent.fsdv3-1.fna&oh=cf795e971ec81487edd9e28a150d6f8b&oe=5FE9D699)](https://scontent.fsdv3-1.fna.fbcdn.net/v/t1.0-9/128051215_3566632900071057_973295284218645986_o.jpg?_nc_cat=107&ccb=2&_nc_sid=0debeb&_nc_ohc=XEetpKHWYGMAX8Np80C&_nc_ht=scontent.fsdv3-1.fna&oh=cf795e971ec81487edd9e28a150d6f8b&oe=5FE9D699)

[![](https://scontent.fsdv3-1.fna.fbcdn.net/v/t1.0-9/128063549_3566632893404391_8879213314983680508_o.jpg?_nc_cat=104&ccb=2&_nc_sid=0debeb&_nc_ohc=AGogmRCVvagAX-V08W-&_nc_ht=scontent.fsdv3-1.fna&oh=a0a02ad92a52735015f72e7410beffd4&oe=5FEAA899)](https://scontent.fsdv3-1.fna.fbcdn.net/v/t1.0-9/128063549_3566632893404391_8879213314983680508_o.jpg?_nc_cat=104&ccb=2&_nc_sid=0debeb&_nc_ohc=AGogmRCVvagAX-V08W-&_nc_ht=scontent.fsdv3-1.fna&oh=a0a02ad92a52735015f72e7410beffd4&oe=5FEAA899)




