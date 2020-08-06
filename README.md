# Test-Task
Application that could help to track time for employees

Приложение создано при помощи WinForms. 

- При загрузке приложения вы оказываетесь на форме MainWindow. Кнопки на данный момент заблокированы, это сделано чтобы пользователь не мог добавить новый проект\сохранить историю, не авторизировавшись. Кнопки разблокируются после закрытия окна авторизации(Log In), однако, тут есть недочет: если вы не зашли в систему, а просто закрыли форму авторизации, то кнопки все равно разблокируются.
- Без авторизации вы не можете смотреть вашу историю и вашу информацию. 
- Без авторизации вам не покажутся никакие проекты (они подвязаны на определенного пользователя).
- При авторизации вы можете зарегистрироваться и новый пользователь будет внесен в бд. (Если такой логин в системе уже существует, запись создана не будет). 
- Если при авторизации вы ввели не тот логин - вы не зайдете в систему.

После авторизации:
1. Вам открывается ваша информация (My Info), где вы можете изменить свою информацию и посмотреть свои проекты (на форме Your Projects нужно сперва выбрать проект из списка, чтобы увидеть информацию о нем и изменить её. Если попытаться изменить поля, не выбрав проект, будет выдана просьба о выборе проекта). Также на форме Your Project можно удалить проект. 
2. На главной форме в списке вы сможете выбрать один из своих проектов. Можно добавить проект, который будет подвязан на ваш аккаунт. (Однако, чтобы его увидеть в списке надо обновить список Update list).
3. Вам доступна ваша история, где вы можете посмотреть историю за текущ. день и за всё время

 Чтобы добавить новую историю, вы заполняете все поля на главной форме и нажимаете на Save. К сожалению, со временем работы (Work start/Work End) вышло не очень удобно, т.к. при нажатии на dateTimePicker у нас показывается календарь, где время выбрать не выходит, поэтому надо вручную изменять часы и минуты нажимая именно на них. 
 Если мы не заполнили все поля и пытаемся сохранить - срабатывает конструкция try..catch и в LogFile.log записывается данное исключение
