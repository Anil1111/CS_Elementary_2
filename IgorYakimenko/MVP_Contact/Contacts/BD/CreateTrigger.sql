drop trigger Delet_record

DELIMITER $$
CREATE TRIGGER Delet_record BEFORE Delete ON contact_fio
FOR EACH ROW BEGIN
   Delete from contact_list where fio_id = old.id_fio;
END;
