-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 30, 2019 at 04:51 PM
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
-- Table structure for table `course`
--

CREATE TABLE `course` (
  `course_id` int(11) NOT NULL,
  `course_code` varchar(32) NOT NULL,
  `course_title` mediumtext NOT NULL,
  `course_type` enum('BSIT','BSCS','BSIS','BSLIS') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `course`
--

INSERT INTO `course` (`course_id`, `course_code`, `course_title`, `course_type`) VALUES
(1, 'IT 1101', 'PROGRAMMING I', 'BSIT'),
(2, 'IT 1102', 'INTRODUCTION TO COMPUTING', 'BSIT'),
(5, 'IT 1103', 'DISCRETE STRUCTURES', 'BSIT'),
(6, 'IT 1201', 'PROGRAMMING II', 'BSIT'),
(7, 'IT 1202', 'NETWORKING I', 'BSIT'),
(8, 'IT 1203', 'HUMAN COMPUTER INTERACTION', 'BSIT'),
(9, 'IT 2101', 'INFORMATION MANAGEMENT', 'BSIT'),
(10, 'IT 2102', 'DATA STRUCTURES AND ALGORITHMS', 'BSIT'),
(14, 'IS 1101', 'PROGRAMMING I', 'BSIS'),
(15, 'CS 1101', 'PROGRAMMING I', 'BSCS');

-- --------------------------------------------------------

--
-- Table structure for table `enroll`
--

CREATE TABLE `enroll` (
  `enroll_id` int(11) NOT NULL,
  `course_id` int(11) NOT NULL,
  `stud_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `enroll`
--

INSERT INTO `enroll` (`enroll_id`, `course_id`, `stud_id`) VALUES
(1, 1, 1),
(3, 2, 1),
(4, 7, 1),
(5, 2, 3),
(6, 8, 1),
(7, 14, 3);

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
(1, 15200155, 'Francis Anthony Carmel', 'Jacobo', 'Caboyo', 'BSIT', '3', '1998-07-24', 'Male', '2019-03-06 16:31:21'),
(2, 16210164, 'Frank', 'Sio', 'Sinatra', 'BSIT', '3', '1998-03-10', 'Male', '2019-03-10 00:18:59'),
(3, 15101254, 'Capitao', 'Santos', 'Maria', 'BSIS', '1', '1998-05-01', 'Female', '2019-03-10 00:25:54'),
(11, 16100213, 'Peter', 'Oraio', 'Dela Cruz', 'BSLIS', '1', '1979-07-02', 'Male', '2019-03-13 21:26:07'),
(12, 16204321, 'Margarette', 'Pranto', 'Viscaya', 'BSCS', '1', '1997-04-05', 'Female', '2019-03-13 21:26:54'),
(13, 15101253, 'Oliver', 'Reyes', 'Jake', 'BSLIS', '1', '1998-06-19', 'Male', '2019-03-15 17:00:55'),
(14, 16211012, 'Sebastian', 'Miguel', 'Ramos', 'BSLIS', '1', '1997-11-14', 'Male', '2019-03-22 19:59:17'),
(15, 15100146, 'Alexis', 'Minaro', 'Jocinta', 'BSIS', '2', '1997-07-14', 'Female', '2019-03-27 14:03:16');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `course`
--
ALTER TABLE `course`
  ADD PRIMARY KEY (`course_id`);

--
-- Indexes for table `enroll`
--
ALTER TABLE `enroll`
  ADD PRIMARY KEY (`enroll_id`),
  ADD KEY `e_course_id` (`course_id`),
  ADD KEY `e_stud_id` (`stud_id`);

--
-- Indexes for table `student`
--
ALTER TABLE `student`
  ADD PRIMARY KEY (`stud_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `course`
--
ALTER TABLE `course`
  MODIFY `course_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `enroll`
--
ALTER TABLE `enroll`
  MODIFY `enroll_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `student`
--
ALTER TABLE `student`
  MODIFY `stud_id` int(11) NOT NULL AUTO_INCREMENT COMMENT 'Identifier', AUTO_INCREMENT=16;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `enroll`
--
ALTER TABLE `enroll`
  ADD CONSTRAINT `e_course_id` FOREIGN KEY (`course_id`) REFERENCES `course` (`course_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `e_stud_id` FOREIGN KEY (`stud_id`) REFERENCES `student` (`stud_id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
