CREATE TABLE `ssm_sentence` (
    `id` int NOT NULL AUTO_INCREMENT COMMENT 'Id',
    `content` varchar(100) NULL COMMENT 'Content',
    `data_status` int NULL DEFAULT 0 COMMENT 'DataStatus',
    `create_time` datetime NULL COMMENT 'CreateTime',
    `last_update_time` datetime NULL COMMENT 'LastUpdateTime',
  PRIMARY KEY (`id`)
) DEFAULT CHARSET=utf8mb4 COMMENT='Sentence';

