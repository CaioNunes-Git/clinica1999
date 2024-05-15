package br.ucsal.clinica.model;

import jakarta.persistence.*;
import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Data;
import lombok.NoArgsConstructor;


import java.time.LocalDateTime;

@Entity
@Table(name = "atestado")
@AllArgsConstructor
@NoArgsConstructor
@Data
public class Atestado {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long idAtestado;
    private Integer quantidadeDias;
    private LocalDateTime dataEmissao;

    @ManyToOne
    private Funcionario funcionario;

    @ManyToOne
    private Medico medico;
}
