--Para usar logings desde base de datos
exec sp_configure 'contained database authentication', 1
go
reconfigure
go

alter database Restaurant
set containment = partial
go

-- Para que el usuario pueda ejectitar SP
GRANT Execute ON [dbo].fnc_whatEver TO [domain\user]