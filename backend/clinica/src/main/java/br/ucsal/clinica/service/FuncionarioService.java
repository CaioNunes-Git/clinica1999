package br.ucsal.clinica.service;

import br.ucsal.clinica.model.Funcionario;
import br.ucsal.clinica.repository.FuncionarioRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.data.domain.Page;
import org.springframework.data.domain.Pageable;
import org.springframework.stereotype.Service;

@Service
public class FuncionarioService {
    @Autowired
    FuncionarioRepository funcionarioRepository;
    public Page<Funcionario> findAll(Pageable pageable) {
        return funcionarioRepository.findAll(pageable);
    }
}
