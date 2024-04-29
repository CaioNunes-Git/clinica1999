package br.ucsal.clinica.model;

import jakarta.persistence.*;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;
import org.springframework.data.relational.core.mapping.Table;

import java.time.LocalDateTime;

@Entity
@Table("funcionario")
@AllArgsConstructor
@NoArgsConstructor
@Data
public class Funcionario {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;
    private String nome;
    private LocalDateTime dataNascimento;

    @OneToOne
    @JoinColumn(name = "cargo_id")
    private Cargo cargo;

    @OneToOne
    @JoinColumn(name = "empresa_id")
    private Empresa empresa;
}
