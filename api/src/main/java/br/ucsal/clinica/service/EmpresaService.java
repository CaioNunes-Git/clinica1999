package br.ucsal.clinica.service;

import br.ucsal.clinica.model.Empresa;
import br.ucsal.clinica.repository.EmpresaRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.data.domain.Page;
import org.springframework.data.domain.Pageable;
import org.springframework.stereotype.Service;

import java.util.NoSuchElementException;

@Service
public class EmpresaService {

    @Autowired
    EmpresaRepository empresaRepository;

    public Page<Empresa> findAll(Pageable pageable) {
        return empresaRepository.findAll(pageable);
    }

    public Empresa findById(Long id) {
        return empresaRepository.findById(id)
                .orElseThrow(() -> new NoSuchElementException("ID da empresa não encontrado " + id));
    }

    public Empresa save(Empresa empresa) {
        if(empresa != null && empresa.getId() != null) {
            return empresaRepository.save(empresa);
        }
        throw new IllegalArgumentException("ID da empresa não pode ser nulo para salvar uma nova empresa");
    }

    public Empresa update(Empresa empresa) {
        findById(empresa.getId());
        return empresaRepository.save(empresa);
    }

    public void delete(Long id) {
        findById(id);
        empresaRepository.deleteById(id);
    }
}
