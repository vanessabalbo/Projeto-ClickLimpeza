-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 30-Jul-2022 às 03:14
-- Versão do servidor: 10.4.24-MariaDB
-- versão do PHP: 7.4.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `click_limpeza`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `cargos`
--

CREATE TABLE `cargos` (
  `id` int(11) NOT NULL,
  `nome_cargo` varchar(60) NOT NULL,
  `salario` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `cargos`
--

INSERT INTO `cargos` (`id`, `nome_cargo`, `salario`) VALUES
(1, 'auxiliar', 1212),
(2, 'lider', 1818),
(3, 'atendente', 1550),
(4, 'gerente', 3500);

-- --------------------------------------------------------

--
-- Estrutura da tabela `clientes`
--

CREATE TABLE `clientes` (
  `id` int(11) NOT NULL,
  `nome_completo` varchar(250) NOT NULL,
  `telefone` varchar(45) NOT NULL,
  `email` varchar(500) DEFAULT NULL,
  `endereco` varchar(500) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `clientes`
--

INSERT INTO `clientes` (`id`, `nome_completo`, `telefone`, `email`, `endereco`) VALUES
(1, 'Fernando das Neves', '12 98123-4562', 'Bradeord893@gmail.com', 'Rodovia Isabella Silva, 5110'),
(2, 'Caroline Silveira', '12 985476352', 'Preciosa3051@gmail.com', 'Travessa Bryan Braga, 27'),
(3, 'Augusto Nunes', '12 975841236', 'Junieta5231@gmail.com', 'Alameda Alexandre Carvalho, 9939'),
(4, 'Emanuelly Porto', '12 985143269', 'Amias6561@gmail.com', 'Marginal Alessandro Costa, 7459, Apto. 540 '),
(5, 'Bruno Barbosa', '12 974851425', 'Monjo5381@gmail.com', 'Rua Frederico Xavier, 4931, Sala 15'),
(6, 'Marina Moreira', '12 963851475', 'Bentley9614@gmail.com', 'Rua Mércia Carvalho, 753'),
(7, 'Juliana Gomes', '12 975621587', 'Hewe4886@gmail.com', 'Alameda Alícia Santos, 651, Sala 5'),
(8, 'Maria Clara Vieira', '12 996857412', 'Heinrick8537@gmail.com', 'Travessa Larissa Souza, 1879, Apto. 650'),
(9, 'Vitor Gabriel da Rosa', '12 996325689', 'Eglantine3196@gmail.com', 'Travessa Joana Batista, 952, Bloco A, Apto. 6'),
(10, 'João Gabriel Cardoso', '11 985743656', 'Bella6814@gmail.com', 'Rua Pietro Reis, 238'),
(11, 'Pedro Henrique Alves', '19 974856352', 'Acker6493@gmail.com', 'Alameda Davi Pereira, 78'),
(12, 'Henrique Lopes', '11 985457836', 'Chatterjee1753@gmail.com', 'Marginal Alessandro Oliveira, 96'),
(13, 'Carolina Gonçalves', '11 978451236', 'Hanfurd5326@gmail.com', 'Rodovia Ana Clara Braga, 83, Apto. 820'),
(14, 'Ana Carolina Barbosa', '19 977856312', 'Aubine1626@gmail.com', 'Avenida Víctor Santos, 46'),
(15, 'Milena Melo', '12 988556321', 'Rabin1601@gmail.com', 'Rua Paula Silva, 955');

-- --------------------------------------------------------

--
-- Estrutura da tabela `funcionarios`
--

CREATE TABLE `funcionarios` (
  `id` int(11) NOT NULL,
  `nome_completo` varchar(250) NOT NULL,
  `email` varchar(500) DEFAULT NULL,
  `telefone` varchar(45) NOT NULL,
  `cargos_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `funcionarios`
--

INSERT INTO `funcionarios` (`id`, `nome_completo`, `email`, `telefone`, `cargos_id`) VALUES
(1, 'Fernanda ramalho silva', 'Erlewine3115@gmail.com', '12979462865', 1),
(2, 'Fernanda ramalho silva', 'Erlewine3115@gmail.com', '12979462865', 1),
(3, 'Mário ribeiro júnior', 'Bainter2602@gmail.co', '12473565866', 1),
(4, 'Mário ribeiro júnior', 'Bainter2602@gmail.co', '12473565866', 1),
(5, 'Diego Freitas', 'Horacio9391@gmail.com', '1285738574', 1),
(6, 'Thiago Nogueira', 'Rudelson6816@gmail.com', '1285846564', 1),
(7, 'Rafaela Pinto', 'Riplex5968@gmail.com', '12755239603', 1),
(8, 'Luiz Otávio Pereira', 'Hesper2390@gmail.com', '1259826435', 1),
(9, 'Ana Carolina da Cruz', 'Alvord1570@gmail.com', '1278913698', 1),
(10, 'Melissa da Paz', 'Jacintha7454@gmail.com', '1267315982', 1),
(11, 'Luiz Henrique Martins', 'Ezana5618@gmail.com', '12658120396', 1),
(12, 'Heitor Fogaça', 'Hintze7671@gmail.com', '12038971235', 2),
(13, 'Vitor Ribeiro', 'Sharp6687@gmail.com', '1295687430', 3),
(14, 'Noah Viana', 'Bess4101@gmail.com', '12532987236', 3),
(15, 'Luiza Barbosa', 'Jannelle9574@gmail.com', '12036845613', 4),
(16, 'Maria Sophia da Luz', 'Loring4713@gmail.com', '1231587625', 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `ordem_servico`
--

CREATE TABLE `ordem_servico` (
  `id` int(11) NOT NULL,
  `clientes_id` int(11) NOT NULL,
  `situacao` tinyint(1) NOT NULL,
  `servicos_id` int(11) NOT NULL,
  `funcionarios_id` int(11) NOT NULL,
  `funcionarios_cargos_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `servicos`
--

CREATE TABLE `servicos` (
  `id` int(11) NOT NULL,
  `nome` varchar(60) NOT NULL,
  `valor` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `servicos`
--

INSERT INTO `servicos` (`id`, `nome`, `valor`) VALUES
(1, 'Limpeza Simples', 140),
(2, 'Limpeza Domestica', 250),
(3, 'Limpeza Empresarial', 800);

-- --------------------------------------------------------

--
-- Estrutura stand-in para vista `view_ordem`
-- (Veja abaixo para a view atual)
--
CREATE TABLE `view_ordem` (
`ID_Ordem` int(11)
,`Cliente` varchar(250)
,`SevicoPrestado` varchar(60)
,`Total` double
,`Executante` varchar(250)
);

-- --------------------------------------------------------

--
-- Estrutura para vista `view_ordem`
--
DROP TABLE IF EXISTS `view_ordem`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_ordem`  AS SELECT `ordem_servico`.`id` AS `ID_Ordem`, `clientes`.`nome_completo` AS `Cliente`, `servicos`.`nome` AS `SevicoPrestado`, `servicos`.`valor` AS `Total`, `funcionarios`.`nome_completo` AS `Executante` FROM (((`ordem_servico` join `clientes` on(`ordem_servico`.`clientes_id` = `clientes`.`id`)) join `funcionarios` on(`ordem_servico`.`funcionarios_id` = `funcionarios`.`id`)) join `servicos` on(`ordem_servico`.`servicos_id` = `servicos`.`id`))  ;

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `cargos`
--
ALTER TABLE `cargos`
  ADD PRIMARY KEY (`id`);

--
-- Índices para tabela `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id_UNIQUE` (`id`);

--
-- Índices para tabela `funcionarios`
--
ALTER TABLE `funcionarios`
  ADD PRIMARY KEY (`id`,`cargos_id`),
  ADD UNIQUE KEY `id_UNIQUE` (`id`),
  ADD KEY `fk_funcionarios_cargos1_idx` (`cargos_id`);

--
-- Índices para tabela `ordem_servico`
--
ALTER TABLE `ordem_servico`
  ADD PRIMARY KEY (`id`,`clientes_id`,`servicos_id`,`funcionarios_cargos_id`,`funcionarios_id`),
  ADD KEY `fk_ordem_servico_clientes_idx` (`clientes_id`),
  ADD KEY `fk_ordem_servico_servicos1_idx` (`servicos_id`),
  ADD KEY `fk_ordem_servico_funcionarios1_idx` (`funcionarios_id`,`funcionarios_cargos_id`);

--
-- Índices para tabela `servicos`
--
ALTER TABLE `servicos`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id_UNIQUE` (`id`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `cargos`
--
ALTER TABLE `cargos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de tabela `clientes`
--
ALTER TABLE `clientes`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT de tabela `funcionarios`
--
ALTER TABLE `funcionarios`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT de tabela `ordem_servico`
--
ALTER TABLE `ordem_servico`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `servicos`
--
ALTER TABLE `servicos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `funcionarios`
--
ALTER TABLE `funcionarios`
  ADD CONSTRAINT `fk_funcionarios_cargos1` FOREIGN KEY (`cargos_id`) REFERENCES `cargos` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Limitadores para a tabela `ordem_servico`
--
ALTER TABLE `ordem_servico`
  ADD CONSTRAINT `fk_ordem_servico_clientes` FOREIGN KEY (`clientes_id`) REFERENCES `clientes` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_ordem_servico_funcionarios1` FOREIGN KEY (`funcionarios_id`,`funcionarios_cargos_id`) REFERENCES `funcionarios` (`id`, `cargos_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_ordem_servico_servicos1` FOREIGN KEY (`servicos_id`) REFERENCES `servicos` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
