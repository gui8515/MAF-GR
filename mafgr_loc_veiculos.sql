-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 29-Maio-2019 às 02:30
-- Versão do servidor: 10.1.38-MariaDB
-- versão do PHP: 7.3.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `mafgr_loc_veiculos`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_cliente`
--

CREATE TABLE `tb_cliente` (
  `ID_cliente` bigint(20) UNSIGNED NOT NULL,
  `CNH` int(11) NOT NULL,
  `CPF` varchar(14) DEFAULT NULL,
  `Data_nasc` date DEFAULT NULL,
  `Nome` varchar(100) DEFAULT NULL,
  `CEP` varchar(10) DEFAULT NULL,
  `Rua` varchar(100) DEFAULT NULL,
  `Numero` decimal(50,0) DEFAULT NULL,
  `Bairro` varchar(50) DEFAULT NULL,
  `Cidade` varchar(20) DEFAULT NULL,
  `Estado` varchar(50) DEFAULT NULL,
  `UF` varchar(2) DEFAULT NULL,
  `Telefone` varchar(15) DEFAULT NULL,
  `E_mail` varchar(50) DEFAULT NULL,
  `Cam_imagem` varchar(500) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_funcionario`
--

CREATE TABLE `tb_funcionario` (
  `ID_func` bigint(20) UNSIGNED NOT NULL,
  `CPF` varchar(14) NOT NULL,
  `Data_nasc` date DEFAULT NULL,
  `Nome` varchar(100) DEFAULT NULL,
  `CEP` varchar(10) DEFAULT NULL,
  `Rua` varchar(100) DEFAULT NULL,
  `Numero` decimal(50,0) DEFAULT NULL,
  `Bairro` varchar(50) DEFAULT NULL,
  `Cidade` varchar(20) DEFAULT NULL,
  `Estado` varchar(50) DEFAULT NULL,
  `UF` varchar(2) DEFAULT NULL,
  `Telefone` varchar(15) DEFAULT NULL,
  `E_mail` varchar(50) DEFAULT NULL,
  `Login` varchar(20) DEFAULT NULL,
  `Senha` varchar(20) DEFAULT NULL,
  `Cam_imagem` varchar(500) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_veiculo`
--

CREATE TABLE `tb_veiculo` (
  `ID_veiculo` bigint(20) UNSIGNED NOT NULL,
  `Placa` int(11) NOT NULL,
  `UF` varchar(2) DEFAULT NULL,
  `Renavam` decimal(50,0) DEFAULT NULL,
  `Cor` varchar(20) DEFAULT NULL,
  `Fabricante` varchar(50) DEFAULT NULL,
  `Modelo` varchar(10) DEFAULT NULL,
  `Ano` varchar(10) DEFAULT NULL,
  `Categoria` varchar(50) DEFAULT NULL,
  `Kilomet` decimal(50,0) DEFAULT NULL,
  `Status_veic` varchar(20) DEFAULT NULL,
  `Cam_imagem` varchar(500) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tb_cliente`
--
ALTER TABLE `tb_cliente`
  ADD PRIMARY KEY (`ID_cliente`,`CNH`),
  ADD UNIQUE KEY `ID_cliente` (`ID_cliente`);

--
-- Indexes for table `tb_funcionario`
--
ALTER TABLE `tb_funcionario`
  ADD PRIMARY KEY (`ID_func`,`CPF`),
  ADD UNIQUE KEY `ID_func` (`ID_func`);

--
-- Indexes for table `tb_veiculo`
--
ALTER TABLE `tb_veiculo`
  ADD PRIMARY KEY (`ID_veiculo`,`Placa`),
  ADD UNIQUE KEY `ID_veiculo` (`ID_veiculo`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tb_cliente`
--
ALTER TABLE `tb_cliente`
  MODIFY `ID_cliente` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tb_funcionario`
--
ALTER TABLE `tb_funcionario`
  MODIFY `ID_func` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tb_veiculo`
--
ALTER TABLE `tb_veiculo`
  MODIFY `ID_veiculo` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
