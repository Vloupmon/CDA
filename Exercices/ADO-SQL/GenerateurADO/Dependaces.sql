select distinct 'name' = (s.name + '.' + o.name),
		schemaName = s.name,
		objectName=o.name			
			from sys.objects o inner join sysdepends d
			on  o.object_id = d.id
			inner join sys.schemas s 
			on o.schema_id = s.schema_id
			
			where
				d.depid = object_id('dbo.customers')
				and o.schema_id = s.schema_id
				and o.type like 'P'
				and deptype < 2
