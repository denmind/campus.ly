-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 16, 2019 at 02:27 PM
-- Server version: 10.1.26-MariaDB
-- PHP Version: 7.1.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `campus.ly`
--

-- --------------------------------------------------------

--
-- Table structure for table `student`
--

CREATE TABLE `student` (
  `stud_id` int(11) NOT NULL COMMENT 'Identifier',
  `stud_id_no` int(11) NOT NULL COMMENT 'ID Card Number',
  `stud_name_first` text NOT NULL,
  `stud_name_mi` varchar(32) DEFAULT '',
  `stud_name_last` text NOT NULL,
  `stud_course` enum('BSIT','BSCS','BSIS','BSLIS') NOT NULL,
  `stud_course_yr` enum('1','2','3','4','5') NOT NULL DEFAULT '1',
  `stud_date_of_birth` date NOT NULL,
  `stud_gender` enum('Male','Female') NOT NULL,
  `date_added` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `student`
--

INSERT INTO `student` (`stud_id`, `stud_id_no`, `stud_name_first`, `stud_name_mi`, `stud_name_last`, `stud_course`, `stud_course_yr`, `stud_date_of_birth`, `stud_gender`, `date_added`) VALUES
(1, 15200155, 'Caboyo', 'Jacobo', 'Francis Anthony Carmel', 'BSIT', '3', '1998-07-24', 'Male', '2019-03-06 16:31:21'),
(2, 1621164, 'Frank', 'Sio', 'Sinatra', 'BSIT', '3', '1998-03-10', 'Male', '2019-03-10 00:18:59'),
(3, 15101254, 'Maria', 'Santos', 'Capitao', 'BSIS', '2', '1984-12-13', 'Female', '2019-03-10 00:25:54'),
(11, 16100213, 'Peter', 'Oraio', 'Dela Cruz', 'BSLIS', '1', '1979-07-02', 'Male', '2019-03-13 21:26:07'),
(12, 16204321, 'Margarette', 'Pranto', 'Viscaya', 'BSCS', '1', '1997-04-05', 'Female', '2019-03-13 21:26:54'),
(13, 15101253, 'Oliver', 'Reyes', 'Jake', 'BSLIS', '1', '1998-06-19', 'Male', '2019-03-15 17:00:55');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `student`
--
ALTER TABLE `student`
  ADD PRIMARY KEY (`stud_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `student`
--
ALTER TABLE `student`
  MODIFY `stud_id` int(11) NOT NULL AUTO_INCREMENT COMMENT 'Identifier', AUTO_INCREMENT=14;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
