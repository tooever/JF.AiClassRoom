/*
Navicat MySQL Data Transfer

Source Server         : local
Source Server Version : 50729
Source Host           : localhost:3306
Source Database       : ssmtest

Target Server Type    : MYSQL
Target Server Version : 50729
File Encoding         : 65001

*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for book
-- ----------------------------
DROP TABLE IF EXISTS `book`;
CREATE TABLE `book` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(60) CHARACTER SET gbk DEFAULT NULL,
  `writer` varchar(60) CHARACTER SET gbk DEFAULT NULL,
  `price` int(10) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=621 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of book
-- ----------------------------
INSERT INTO `book` VALUES ('1', '书名1', '作者1', '11');
INSERT INTO `book` VALUES ('2', '书名2', '作者2u', '12');
INSERT INTO `book` VALUES ('518', '书名3', '作者3', '13');
INSERT INTO `book` VALUES ('519', '书名4', '作者4m', '14');
INSERT INTO `book` VALUES ('520', '书名5', '作者5', '15');
INSERT INTO `book` VALUES ('521', '书名6', '作者6', '16');
INSERT INTO `book` VALUES ('522', '书名7', '作者7', '17');
INSERT INTO `book` VALUES ('523', '书名8', '作者8', '18');
INSERT INTO `book` VALUES ('524', '书名9', '作者9', '19');
INSERT INTO `book` VALUES ('525', '书名10', '作者10', '20');
INSERT INTO `book` VALUES ('526', '书名11', '作者11', '21');
INSERT INTO `book` VALUES ('527', '书名12', '作者12', '22');
INSERT INTO `book` VALUES ('528', '书名13', '作者13', '23');
INSERT INTO `book` VALUES ('529', '书名14', '作者14', '24');
INSERT INTO `book` VALUES ('530', '书名15', '作者15', '25');
INSERT INTO `book` VALUES ('531', '书名16', '作者16', '26');
INSERT INTO `book` VALUES ('532', '书名17', '作者17', '27');
INSERT INTO `book` VALUES ('533', '书名18', '作者18', '28');
INSERT INTO `book` VALUES ('534', '书名19', '作者19', '29');
INSERT INTO `book` VALUES ('535', '书名20', '作者20', '30');
INSERT INTO `book` VALUES ('536', '书名21', '作者21', '31');
INSERT INTO `book` VALUES ('537', '书名22', '作者22', '32');
INSERT INTO `book` VALUES ('538', '书名23', '作者23', '33');
INSERT INTO `book` VALUES ('539', '书名24', '作者24', '34');
INSERT INTO `book` VALUES ('540', '书名25', '作者25', '35');
INSERT INTO `book` VALUES ('541', '书名26', '作者26', '36');
INSERT INTO `book` VALUES ('542', '书名27', '作者27', '37');
INSERT INTO `book` VALUES ('543', '书名28', '作者28', '38');
INSERT INTO `book` VALUES ('544', '书名29', '作者29', '39');
INSERT INTO `book` VALUES ('545', '书名30', '作者30', '40');
INSERT INTO `book` VALUES ('546', '书名31', '作者31', '41');
INSERT INTO `book` VALUES ('547', '书名32', '作者32', '42');
INSERT INTO `book` VALUES ('548', '书名33', '作者33', '43');
INSERT INTO `book` VALUES ('549', '书名34', '作者34', '44');
INSERT INTO `book` VALUES ('550', '书名35', '作者35', '45');
INSERT INTO `book` VALUES ('551', '书名36', '作者36', '46');
INSERT INTO `book` VALUES ('552', '书名37', '作者37', '47');
INSERT INTO `book` VALUES ('553', '书名38', '作者38', '48');
INSERT INTO `book` VALUES ('554', '书名39', '作者39', '49');
INSERT INTO `book` VALUES ('555', '书名40', '作者40', '50');
INSERT INTO `book` VALUES ('556', '书名41', '作者41', '51');
INSERT INTO `book` VALUES ('557', '书名42', '作者42', '52');
INSERT INTO `book` VALUES ('558', '书名43', '作者43', '53');
INSERT INTO `book` VALUES ('559', '书名44', '作者44', '54');
INSERT INTO `book` VALUES ('560', '书名45', '作者45', '55');
INSERT INTO `book` VALUES ('561', '书名46', '作者46', '56');
INSERT INTO `book` VALUES ('562', '书名47', '作者47', '57');
INSERT INTO `book` VALUES ('563', '书名48', '作者48', '58');
INSERT INTO `book` VALUES ('564', '书名49', '作者49', '59');
INSERT INTO `book` VALUES ('565', '书名50', '作者50', '60');
INSERT INTO `book` VALUES ('566', '书名51', '作者51', '61');
INSERT INTO `book` VALUES ('567', '书名52', '作者52', '62');
INSERT INTO `book` VALUES ('568', '书名53', '作者53', '63');
INSERT INTO `book` VALUES ('569', '书名54', '作者54', '64');
INSERT INTO `book` VALUES ('570', '书名55', '作者55', '65');
INSERT INTO `book` VALUES ('571', '书名56', '作者56', '66');
INSERT INTO `book` VALUES ('572', '书名57', '作者57', '67');
INSERT INTO `book` VALUES ('573', '书名58', '作者58', '68');
INSERT INTO `book` VALUES ('574', '书名59', '作者59', '69');
INSERT INTO `book` VALUES ('575', '书名60', '作者60', '70');
INSERT INTO `book` VALUES ('576', '书名61', '作者61', '71');
INSERT INTO `book` VALUES ('577', '书名62', '作者62', '72');
INSERT INTO `book` VALUES ('578', '书名63', '作者63', '73');
INSERT INTO `book` VALUES ('579', '书名64', '作者64', '74');
INSERT INTO `book` VALUES ('580', '书名65', '作者65', '75');
INSERT INTO `book` VALUES ('581', '书名66', '作者66', '76');
INSERT INTO `book` VALUES ('582', '书名67', '作者67', '77');
INSERT INTO `book` VALUES ('583', '书名68', '作者68', '78');
INSERT INTO `book` VALUES ('584', '书名69', '作者69', '79');
INSERT INTO `book` VALUES ('585', '书名70', '作者70', '80');
INSERT INTO `book` VALUES ('586', '书名71', '作者71', '81');
INSERT INTO `book` VALUES ('587', '书名72', '作者72', '82');
INSERT INTO `book` VALUES ('588', '书名73', '作者73', '83');
INSERT INTO `book` VALUES ('589', '书名74', '作者74', '84');
INSERT INTO `book` VALUES ('590', '书名75', '作者75', '85');
INSERT INTO `book` VALUES ('591', '书名76', '作者76', '86');
INSERT INTO `book` VALUES ('592', '书名77', '作者77', '87');
INSERT INTO `book` VALUES ('593', '书名78', '作者78', '88');
INSERT INTO `book` VALUES ('594', '书名79', '作者79', '89');
INSERT INTO `book` VALUES ('595', '书名80', '作者80', '90');
INSERT INTO `book` VALUES ('596', '书名81', '作者81', '91');
INSERT INTO `book` VALUES ('597', '书名82', '作者82', '92');
INSERT INTO `book` VALUES ('598', '书名83', '作者83', '93');
INSERT INTO `book` VALUES ('599', '书名84', '作者84', '94');
INSERT INTO `book` VALUES ('600', '书名85', '作者85', '95');
INSERT INTO `book` VALUES ('601', '书名86', '作者86', '96');
INSERT INTO `book` VALUES ('602', '书名87', '作者87', '97');
INSERT INTO `book` VALUES ('603', '书名88', '作者88', '98');
INSERT INTO `book` VALUES ('604', '书名89', '作者89', '99');
INSERT INTO `book` VALUES ('605', '书名90', '作者90', '100');
INSERT INTO `book` VALUES ('606', '书名91', '作者91', '101');
INSERT INTO `book` VALUES ('607', '书名92', '作者92', '102');
INSERT INTO `book` VALUES ('608', '书名93', '作者93', '103');
INSERT INTO `book` VALUES ('609', '书名94', '作者94', '104');
INSERT INTO `book` VALUES ('610', '书名95', '作者95', '105');
INSERT INTO `book` VALUES ('611', '书名96', '作者96', '106');
INSERT INTO `book` VALUES ('612', '书名97', '作者97', '107');
INSERT INTO `book` VALUES ('613', '书名98', '作者98', '108');
INSERT INTO `book` VALUES ('614', '书名99', '作者99', '109');
INSERT INTO `book` VALUES ('615', '书名100', '作者100', '110');
