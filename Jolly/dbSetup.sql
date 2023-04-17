CREATE TABLE IF NOT EXISTS accounts(
  id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name varchar(255) COMMENT 'User Name',
  email varchar(255) COMMENT 'User Email',
  picture varchar(255) COMMENT 'User Picture'
) default charset utf8 COMMENT '';

CREATE TABLE passwords(
  kee VARCHAR(1000) NOT NULL
) default charset utf8 COMMENT '';
CREATE TABLE posts(
  id INT AUTO_INCREMENT PRIMARY KEY,
  body VARCHAR(1000) NOT NULL COMMENT 'the actual text of the post',
  img VARCHAR(255),
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP,
  views INT NOT NULL DEFAULT 0

) default charset utf8 COMMENT '';

DROP TABLE posts;
INSERT INTO posts
(body)
VALUES
('this is test ffrrrrooo!');
DROP TABLE passwords;
INSERT INTO passwords
  (kee)
  VALUES
  ('cheeto')
;


