﻿namespace nylium.Core.World.Generation.Generators {

    public class FlatWorldGenerator : IWorldGenerator {

        public void GenerateChunk(World world, Chunk chunk) {
            for(int x = 0; x < Chunk.X_SIZE; x++) {
                for(int z = 0; z < Chunk.Z_SIZE; z++) {
                    chunk.SetBlock(Block.Block.Create(world, "minecraft:stone", x, 0, z), x, 0, z);

                    if(chunk.X % 2 == 1 && chunk.Z % 2 == 1) {
                        chunk.SetBlock(Block.Block.Create(world, "minecraft:stone", x, 1, z), x, 1, z);
                    }
                }
            }
        }
    }
}